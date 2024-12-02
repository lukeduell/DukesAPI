# API Documentation

## Overview
This API implements multiple forms of data manipulation and utilizes Swagger as a UI for local development testing of all endpoints. To use the endpoints, users must authenticate.

## Authentication
To authenticate with the API:

1. Navigate to the Auth endpoint in the Swagger UI.
2. Click "Try it out".
3. Change the `username` to `test` and `password` to `test`.
4. Execute the request.
5. You will receive a token in the response. Copy this token.
6. Click the "Authorize" button at the top of the Swagger UI.
7. Enter `Bearer {token}` in the authorization field, replacing `{token}` with your copied token.
8. Once completed, you are authorized to use all endpoints.

## Endpoints
This API offers several endpoints for data retrieval and manipulation:

### EspnCollegeFootball
- **Description**: Retrieves data using ESPN's API endpoint.
- **Methods**: Multiple GET calls.
- **Returns**: Data is returned in JSON format.

### Teams
- **Endpoint**: `/api/espn/college-football/GetCFBTeamInformation/{teamId}`
- **Description**: Takes data from the specified ESPN endpoint and adds it to an AWS RDS database.
- **Notes**: The database stores specific fields from the data. Ensure to check the Example value in the Swagger UI to verify that the data conforms to the database schema before adding it.

## Database
- **Type**: AWS RDS
- **Usage**: Holds specific information defined in the schema used by the `Teams` endpoint.

## Getting Started
To start using this API, ensure you follow the authentication steps to access the full capabilities of the endpoints provided.
