export const kenyaCounties = [
  { name: 'Nakuru', code: 'nakuru', region: 'South Rift' },
  { name: 'Bomet', code: 'bomet', region: 'South Rift' },
  { name: 'Narok', code: 'narok', region: 'South Rift' },
  { name: 'Kericho', code: 'kericho', region: 'South Rift' },
  { name: 'Nandi', code: 'nandi', region: 'South Rift' },
  { name: 'Uasin Gishu', code: 'uasin-gishu', region: 'North Rift' },
  { name: 'Trans Nzoia', code: 'trans-nzoia', region: 'North Rift' },
  { name: 'Elgeyo Marakwet', code: 'elgeyo-marakwet', region: 'North Rift' },
  { name: 'West Pokot', code: 'west-pokot', region: 'North Rift' },
  { name: 'Baringo', code: 'baringo', region: 'North Rift' },
  { name: 'Samburu', code: 'samburu', region: 'North Rift' },
  { name: 'Turkana', code: 'turkana', region: 'North Rift' },
  { name: 'Meru', code: 'meru', region: 'Mt. Kenya' },
  { name: 'Tharaka Nithi', code: 'tharaka-nithi', region: 'Mt. Kenya' },
  { name: 'Embu', code: 'embu', region: 'Mt. Kenya' },
  { name: 'Nyeri', code: 'nyeri', region: 'Mt. Kenya' },
  { name: 'Laikipia', code: 'laikipia', region: 'Mt. Kenya' },
  { name: 'Kirinyaga', code: 'kirinyaga', region: 'Central' },
  { name: "Murang'a", code: 'muranga', region: 'Central' },
  { name: 'Nyandarua', code: 'nyandarua', region: 'Central' },
  { name: 'Nairobi', code: 'nairobi', region: 'Nairobi Metropolitan' },
  { name: 'Kiambu', code: 'kiambu', region: 'Nairobi Metropolitan' },
  { name: 'Machakos', code: 'machakos', region: 'Nairobi Metropolitan' },
  { name: 'Kajiado', code: 'kajiado', region: 'Nairobi Metropolitan' },
  { name: 'Mombasa', code: 'mombasa', region: 'Coast' },
  { name: 'Kwale', code: 'kwale', region: 'Coast' },
  { name: 'Kilifi', code: 'kilifi', region: 'Coast' },
  { name: 'Tana River', code: 'tana-river', region: 'Coast' },
  { name: 'Lamu', code: 'lamu', region: 'Coast' },
  { name: 'Taita Taveta', code: 'taita-taveta', region: 'Coast' },
  { name: 'Kakamega', code: 'kakamega', region: 'Western' },
  { name: 'Vihiga', code: 'vihiga', region: 'Western' },
  { name: 'Bungoma', code: 'bungoma', region: 'Western' },
  { name: 'Busia', code: 'busia', region: 'Western' },
  { name: 'Kisumu', code: 'kisumu', region: 'Nyanza' },
  { name: 'Siaya', code: 'siaya', region: 'Nyanza' },
  { name: 'Homa Bay', code: 'homa-bay', region: 'Nyanza' },
  { name: 'Migori', code: 'migori', region: 'Nyanza' },
  { name: 'Kisii', code: 'kisii', region: 'Nyanza' },
  { name: 'Nyamira', code: 'nyamira', region: 'Nyanza' },
  { name: 'Kitui', code: 'kitui', region: 'Eastern' },
  { name: 'Makueni', code: 'makueni', region: 'Eastern' },
  { name: 'Isiolo', code: 'isiolo', region: 'Eastern' },
  { name: 'Marsabit', code: 'marsabit', region: 'Eastern' },
  { name: 'Garissa', code: 'garissa', region: 'North Eastern' },
  { name: 'Wajir', code: 'wajir', region: 'North Eastern' },
  { name: 'Mandera', code: 'mandera', region: 'North Eastern' }
]

export function getAccessibleCounties(role, region, county) {
  if (role === 'principal-secretary') return kenyaCounties.map(c => c.name)
  if (role === 'regional-lead' && region) {
    return kenyaCounties.filter(c => c.region === region).map(c => c.name)
  }
  if (role === 'county-director' && county) return [county]
  return []
}
