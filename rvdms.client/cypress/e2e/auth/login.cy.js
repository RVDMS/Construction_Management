/// <reference types="cypress" />

describe("Login Page - Rift Valley Housing Tracker", () => {
  // helper to generate fake JWT with role claim
  function generateFakeJwt(role) {
    const payload = {
      "http://schemas.microsoft.com/ws/2008/06/identity/claims/role": role,
      exp: Math.floor(Date.now() / 1000) + 3600,
    };

    return `header.${btoa(JSON.stringify(payload))}.signature`;
  }

  beforeEach(() => {
    cy.visit("/login", {
      onBeforeLoad(win) {
        cy.stub(win.navigator.geolocation, "getCurrentPosition").callsFake((success) => {
          success({
            coords: {
              latitude: 0.983978,
              longitude: 34.98466,
            },
          });
        });
      },
    });
  });

  /* ===============================
     UI CHECKS
  =============================== */

  it("should display main UI elements", () => {
    cy.contains("h1", "Affordable Housing Programme").should("be.visible");
    cy.contains("Secure Login").should("be.visible");

    cy.get('input[type="email"]').should("be.visible");
    cy.get('input[type="password"]').should("be.visible");

    cy.contains("button", "Login").should("be.visible");
  });

  it("should toggle password visibility", () => {
    cy.get('input[type="password"]').should("exist");

    cy.get('button[type="button"]').click();
    cy.get('input[type="text"]').should("exist");

    cy.get('button[type="button"]').click();
    cy.get('input[type="password"]').should("exist");
  });

  /* ===============================
     FORM VALIDATION
  =============================== */

  it("should show validation errors for empty fields", () => {
    cy.contains("button", "Login").click();

    cy.contains("Email is required").should("be.visible");
    cy.contains("Password is required").should("be.visible");
  });

  it("should validate email format", () => {
    cy.get('input[type="email"]').type("invalid-email");
    cy.get('input[type="password"]').type("password123");

    cy.contains("button", "Login").click();

    cy.contains("Please enter a valid email address").should("be.visible");
  });

  it("should validate password length", () => {
    cy.get('input[type="email"]').type("test@example.com");
    cy.get('input[type="password"]').type("12345");

    cy.contains("button", "Login").click();

    cy.contains("Password must be at least 6 characters").should("be.visible");
  });

  /* ===============================
     LOGIN SUCCESS
  =============================== */

  it("should login successfully and redirect Regional Lead", () => {
    cy.intercept("POST", "/api/Auth/login", {
      statusCode: 200,
      body: {
        isSuccess: true,
        value: {
          user: {
            id: "RL001",
            email: "rl@test.com",
          },
          accessToken: generateFakeJwt("RL"),
          refreshToken: "fake-refresh",
        },
      },
    }).as("loginRequest");

    cy.get('input[type="email"]').type("rl@test.com");
    cy.get('input[type="password"]').type("Password123");

    cy.contains("button", "Login").click();

    cy.wait("@loginRequest");

    cy.url().should("include", "/dashboard/regional");
  });

  /* ===============================
     LOGIN FAILURE
  =============================== */

  it("should show error for invalid credentials", () => {
    cy.intercept("POST", "/api/Auth/login", {
      statusCode: 200,
      body: {
        isSuccess: false,
        error: "Invalid email or password",
      },
    }).as("failedLogin");

    cy.get('input[type="email"]').type("wrong@test.com");
    cy.get('input[type="password"]').type("WrongPass123");

    cy.contains("button", "Login").click();

    cy.wait("@failedLogin");

    cy.contains("Invalid email or password").should("be.visible");
  });

  /* ===============================
     LOADING STATE
  =============================== */

  it("should show loading spinner during login", () => {
    cy.intercept("POST", "/api/Auth/login", (req) => {
      req.reply({
        delay: 1200,
        statusCode: 200,
        body: {
          isSuccess: true,
          value: {
            user: { id: "COW001" },
            accessToken: generateFakeJwt("COW"),
            refreshToken: "fake-refresh",
          },
        },
      });
    }).as("slowLogin");

    cy.get('input[type="email"]').type("cow@test.com");
    cy.get('input[type="password"]').type("Password123");

    cy.contains("button", "Login").click();

    cy.get(".animate-spin").should("be.visible");
    cy.contains("Verifying location...").should("be.visible");

    cy.wait("@slowLogin");

    cy.get(".animate-spin").should("not.exist");
  });
});
