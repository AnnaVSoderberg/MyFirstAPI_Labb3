# API_Labb3

## Fetch all interests
**Method:** GET
**Endpoint:** /api/Interest
**Description:** Retrieves a list of all interests.
**Example request (curl):** 
```bash
curl -X 'GET' \
  'https://localhost:7278/api/Interest' \
  -H 'accept: */*'
__________________________________________________
## Add a new interest to a person

**Method:** PUT
**Endpoint:** /api/Interest/AddNewInterestToPerson
**Description:** Adds a new interest to an existing person.
**Parameters:**
`interestId`: The ID of the interest to be added.
`personId`: The ID of the person to add the interest to.
**Example request (curl):** 
```bash
curl -X 'PUT' \
  'https://localhost:7278/api/Interest/AddNewInterestToPerson?interestId=1&personId=1' \
  -H 'accept: */*'
__________________________________________________
## Fetch all links

**Method:** GET
**Endpoint:** /api/Link
**Description:** Retrieves a list of all links.
**Example request (curl):** 
```bash
curl -X 'GET' \
  'https://localhost:7278/api/Link' \
  -H 'accept: */*'
__________________________________________________
## Link a person to an interest through a link

**Method:** POST
**Endpoint:** /api/Link/LinkToPersonAndInterest
**Description:** Creates a new link between a person and an interest.
**Example request (curl):** 
```bash
curl -X 'POST' \
  'https://localhost:7278/api/Link/LinkToPersonAndInterest' \
  -H 'accept: */*' \
  -d ''
__________________________________________________
## Fetch all persons

**Method:** GET
**Endpoint:** /api/Person
**Description:** Retrieves a list of all persons.
**Example request (curl):** 
```bash
curl -X 'GET' \
  'https://localhost:7278/api/Person' \
  -H 'accept: */*'
__________________________________________________
## Create a new person

**Method:** POST
**Endpoint:** /api/Person
**Description:** Creates a new person.
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
## Fetch a specific person

**Method:** GET
**Endpoint:** /api/Person/{personId}
**Description:** Retrieves information about a specific person based on the person's ID.
**Parameters:** `personId`: The ID of the person to retrieve.
**Example request (curl):** 
```bash
curl -X 'GET' \
  'https://localhost:7278/api/Person/1' \
  -H 'accept: */*'
__________________________________________________
## Fetch all links for a specific person

**Method:** GET
**Endpoint:** /api/Person/GetPersonLinks
**Description:** Retrieves all links related to a specific person.
**Example request (curl):** 
```bash
curl -X 'GET' \
  'https://localhost:7278/api/Person/GetPersonLinks' \
  -H 'accept: */*'
__________________________________________________
## Fetch all interests for a specific person

**Method:** GET
**Endpoint:** /api/Person/GetAPersonsInterests
**Description:** Retrieves all interests related to a specific person.
**Example request (curl):** 
```bash
curl -X 'GET' \
  'https://localhost:7278/api/Person/GetAPersonsInterests' \
  -H 'accept: */*'
