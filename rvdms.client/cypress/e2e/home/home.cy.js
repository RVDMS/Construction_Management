/// <reference types="cypress" />

describe("Rift Valley Housing Tracker - Landing Page", () => {
  beforeEach(() => {
    // Visit the landing page before each test
    // Uses the baseUrl from config, so just need '/'
    cy.visit("/");
  });

  it("should display the correct title and logos", () => {
    // Check if the page title is correct
    cy.title().should("include", "Rift Valley Housing Tracker");

    // Check if all three ministry logos are visible
    cy.get('img[alt="Ministry of Housing"]').should("be.visible");
    cy.get('img[alt="AHB"]').should("be.visible");
    cy.get('img[alt="Boma Yangu"]').should("be.visible");
  });

  it("should have a working Staff Login button", () => {
    // Find the login button and click it
    cy.get("button").contains("Access Staff Portal").click();

    // Should navigate to login page
    cy.url().should("include", "/login");
  });

  it("should display all staff hierarchy roles", () => {
    // Check if all role cards are present
    const roles = [
      "Regional Lead",
      "County Director of Housing",
      "Technical Lead",
      "Cluster Supervisor",
      "Clerk of Works",
    ];

    roles.forEach((role) => {
      cy.contains("h3", role).should("be.visible");
    });
  });

  it("should show the correct stats", () => {
    // Verify the stats are displayed
    cy.contains("24").should("be.visible"); // Active Projects
    cy.contains("847").should("be.visible"); // Units
    cy.contains("156").should("be.visible"); // Field Staff
    cy.contains("5").should("be.visible"); // Counties
  });
});
