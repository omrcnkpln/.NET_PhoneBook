- [x] use repository pattern
- [x] use unitofwork pattern
- [x] abstractions


- [x] Create Contact Mikroservice.
- [x] Create N-tier arc for this mikroservice.
- [x] Add ef core to project
- [x] Create models and dbcontext for codefirst with efcore.  
- [x] Will be used Postgresql db on docker.
- [x] Connection string has been written Application.json.
- [x] UserRepository create.
- [x] Set Up For Repository Pattern.
- [ ] Crud Opr. for phone book contact.


- [x] Create Report Mikroservice.
- [x] Create Onion Arch. for this mikroservice.
- [ ] Create models and dbcontext for codefirst with efcore. Will be used Postgresql db or mongodb.
- [ ] Crud Opr. for phone book report.
- [ ] Add extra library for grpc calls. Grpc Client.
- [ ] Make unit tests for grpc calls.


- [ ] Create postman collection.
- [ ] Write more clear documentation.

To Run Post Container
	- docker run --name docker_postgres -e POSTGRES_PASSWORD=test -d -p 5432:5432 -v postgres:/var/lib/postgresql/data postgres
	
To Test grpc server with postman
	- grpc://localhost:7081 - UserListDTO