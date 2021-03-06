# Web API Core using React to Fetch data.
## Tech Used
1. .NET web API (Swagger)
2. All CRUD operations. <br>
HTTP Methods:<br>
**CRUD**<br>
a. GET- Read<br>
b. POST - Create<br>
c. PUT- Update - Updates the whole records<br>
d. DELETE - Delete<br>
e. Patch - Update - can update parts of record<br>
3. **Annotations:**<br>
a. GET: [HttpGet]<br>
b. POST: [HttpPost]<br>
c. PUT: [HttPut]<br>
d. DELETE: [HttpDelete]<br>
4. app.UseCors(builder => builder
.AllowAnyOrigin()
.AllowAnyMethod()
.AllowAnyHeader()); **For Fetching**
5. **React application** to **Fetch** all the Data.<br>

server: API <------------------------> Client: React

**API**:
![webapi](https://user-images.githubusercontent.com/73182090/177772868-b0d2ea78-5c7b-4ca4-a847-6e44cfb1fc41.png)
**React Frontend**:<br>
![react](https://user-images.githubusercontent.com/73182090/177772923-d342eeb2-8135-42f1-8d37-2729a9334f70.png)
