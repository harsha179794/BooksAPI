# BooksAPI
REST API using ASP.Net Core and created GET, POST, PUSH and DELETE services for the books item.

Introduction:
            Created a REST API with ASP.Net Core and implemented the GET, POST, PUSH and DELETE services on Books Items.

Model Classes:
            BooksItem Class: This Model class is created to hold and retrieve the data. 
            It contains four properties (Id, BookName, Author, ISBN).
                              
            Books Context: This class is a helper class created to store the POST requests and retrieve the data for GET requests.

Controller: 
            Created four controller for each service. 
            GetBooks for GET request.
            AddBooks for POST request.
            EditBooks for PUT request.
            DeleteBooks for Delete request.
            
GET: I have created two GET requests, one to retrieve all the books available and second GET request is based on the BookId.

POST: I have created two POST requests with two signatures, one which can directly used to POST the data and other 
      POST request using the HTTPPOST attribute with the Actionname.
      
PUSH: I have created a PUSH request to edit the data, it takes the Id as an querystring and then retireves it and edits the data.

DELETE: I have created a DELETE request to delete the data. 




