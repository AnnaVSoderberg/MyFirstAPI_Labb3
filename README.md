# API_Labb3

## Hämta alla intressen
**Metod:** GET
**Endpoint:** /api/interests
**Beskrivning:** Hämtar en lista över alla intressen.
**Exempelanrop (curl):** 
  ```bash
  curl -X 'GET' \
    'https://localhost:7278/api/Interest' \
    -H 'accept: */*'
__________________________________________________
## Lägg till ett nytt intresse till en person

**Metod:** PUT
**Endpoint:** /api/Interest/AddNewInterestToPerson
**Beskrivning:** Lägger till ett nytt intresse till en befintlig person.
**Parametrar:**
`interestId`: ID:t för det intresse som ska läggas till.
 `personId`: ID:t för personen som intresset ska läggas till för.
**Exempelanrop (curl):** 
  ```bash
  curl -X 'PUT' \
    'https://localhost:7278/api/Interest/AddNewInterestToPerson?interestId=1&personId=1' \
    -H 'accept: */*'
__________________________________________________
## Hämta alla länkar

**Metod:** GET
**Endpoint:** /api/Link
**Beskrivning:** Hämtar en lista över alla länkar.
**Exempelanrop (curl):** 
  ```bash
  curl -X 'GET' \
    'https://localhost:7278/api/Link' \
    -H 'accept: */*'
__________________________________________________
## Länka en person till ett intresse genom en länk

**Metod:** POST
**Endpoint:** /api/Link/LinkToPersonAndInterest
**Beskrivning:** Skapar en ny länk mellan en person och ett intresse.
**Exempelanrop (curl):** 
  ```bash
  curl -X 'POST' \
    'https://localhost:7278/api/Link/LinkToPersonAndInterest' \
    -H 'accept: */*' \
    -d ''
__________________________________________________
## Hämta alla personer

**Metod:** GET
**Endpoint:** /api/Person
**Beskrivning:** Hämtar en lista över alla personer.
**Exempelanrop (curl):** 
  ```bash
  curl -X 'GET' \
    'https://localhost:7278/api/Person' \
    -H 'accept: */*'
__________________________________________________
## Skapa en ny person

**Metod:** POST
**Endpoint:** /api/Person
**Beskrivning:** Skapar en ny person.
**Request Headers:** 
  - `accept: */*`
  - `Content-Type: application/json`
- **Request Body:** 
  ```json
  {
    "personId": 0,
    "name": "string",
    "phoneNumber": "string"
  }
__________________________________________________
## Hämta en specifik person

**Metod:** GET
**Endpoint:** /api/Person/{personId}
**Beskrivning:** Hämtar information om en specifik person baserat på personens ID.
**Parametrar:** `personId`: ID:t för den person som ska hämtas.
**Exempelanrop (curl):** 
  ```bash
  curl -X 'GET' \
    'https://localhost:7278/api/Person/1' \
    -H 'accept: */*'
__________________________________________________
## Hämta alla länkar för en specifik person

**Metod:** GET
**Endpoint:** /api/Person/GetPersonLinks
**Beskrivning:** Hämtar alla länkar relaterade till en specifik person.
**Exempelanrop (curl):** 
  ```bash
  curl -X 'GET' \
    'https://localhost:7278/api/Person/GetPersonLinks' \
    -H 'accept: */*'
__________________________________________________
## Hämta alla intressen för en specifik person

**Metod:** GET
**Endpoint:** /api/Person/GetAPersonsInterests
**Beskrivning:** Hämtar alla intressen relaterade till en specifik person.
**Exempelanrop (curl):** 
  ```bash
  curl -X 'GET' \
    'https://localhost:7278/api/Person/GetAPersonsInterests' \
    -H 'accept: */*'
