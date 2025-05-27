## API Testing Frameworks Comparison: Postman vs RestAssured vs Karate vs Supertest

This document compares four popular API testing frameworks: **Postman**, **RestAssured**, **Karate**, and **Supertest**. It includes definitions, use cases, pros and cons, framework structure, supported languages, code examples, integrations with BDD and test reporting tools, handling of assertions and test data, standout advanced features, Docker setup, CI/CD integration, test parallelization, and contract/documentation tools.

---

## 📌 Comparison Table

| Feature                   | Postman                         | RestAssured (Java)              | Karate (Java DSL)               | Supertest (JavaScript)         |
|---------------------------|----------------------------------|----------------------------------|----------------------------------|-------------------------------|
| **Definition**            | GUI-based tool for API testing  | Java library for HTTP requests  | BDD testing DSL for APIs        | HTTP assertions for Node.js   |
| **Usage**                 | Manual/automated API testing    | Automated testing in Java       | BDD-style declarative testing   | Integration & API tests       |
| **Pros**                  | Easy UI, Newman CLI, test data  | Powerful, detailed assertions   | Built-in BDD, no coding needed  | Lightweight, easy to use      |
| **Cons**                  | GUI-focused, JS scripting       | Java-specific, verbose setup    | DSL learning curve              | Less structured, JS only      |
| **Framework**             | Postman Collections & Environments | JUnit/TestNG + RestAssured     | Karate framework                | Mocha + Supertest             |
| **Programming Languages** | JavaScript (for scripts)        | Java                            | Java DSL                        | JavaScript                    |
| **Library Used**          | Postman API + Newman            | RestAssured + Hamcrest          | Karate                          | Supertest + Mocha/Chai        |
| **Run Method**            | Newman CLI                      | JUnit/TestNG                    | `mvn test` or `karate test`     | `npx mocha`                   |
| **BDD Support**           | Via external tools              | With Cucumber                   | Built-in Gherkin DSL            | With cucumber-js              |
| **Report Tools**          | HTML, JSON, JUnit via Newman    | Allure, ExtentReports           | HTML, JUnit                     | Mochawesome, Allure           |
| **Assertions**            | Built-in JS assertions          | Hamcrest matchers               | Native BDD style `Then`         | Chai assertions                |
| **Advanced Features**     | Environment variables, monitors | OAuth2, RequestSpecBuilder      | Built-in mocks, parallel tests  | Simple chaining & setup       |
| **Docker Support**        | ✅ Newman Docker Image           | ✅ Java + Maven/Gradle image     | ✅ Karate Docker                 | ✅ Node + Mocha base image     |
| **CI/CD Integration**     | GitHub Actions, Jenkins, GitLab | Jenkins, GitHub Actions         | GitHub, GitLab CI               | GitHub, GitLab, CircleCI      |
| **Test Parallelization**  | With Newman + reporters         | TestNG parallel suite           | Built-in parallel runner        | Mocha parallel mode           |
| **Swagger/OpenAPI Support**| Import/export collections       | RestAssured + Swagger parser    | Reads OpenAPI with plugins      | Use with swagger-jsdoc        |
| **Contract Testing Tools**| N/A                            | Pact JVM, Spring Cloud Contract | Karate + schema validation      | Pact JS                       |

---

## 📂 Folder Structures and Sample Code

### ✅ Postman + Newman

**Folder Structure:**
```
postman/
  ├── collections/
  │   └── api-tests.postman_collection.json
  └── environments/
      └── staging.postman_environment.json
```

**Run Test:**
```bash
newman run collections/api-tests.postman_collection.json -e environments/staging.postman_environment.json
```

**CI/CD Example (GitHub Actions):**
```yaml
jobs:
  postman-tests:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v2
      - run: npm install -g newman
      - run: newman run collections/api-tests.postman_collection.json
```

---

### ⚡ RestAssured + JUnit/TestNG

**Folder Structure:**
```
src/test/java/
  ├── tests/APITest.java
  └── utils/RequestBuilder.java
```

**Sample Test (JUnit):**
```java
import io.restassured.RestAssured;
import static org.hamcrest.Matchers.*;

@Test
public void testGetUser() {
    RestAssured.get("https://api.example.com/users/1")
        .then()
        .statusCode(200)
        .body("name", equalTo("John"));
}
```

**Dockerfile:**
```dockerfile
FROM maven:3.8.1-jdk-11
COPY . .
RUN mvn clean install
CMD ["mvn", "test"]
```

---

### 💪 Karate Framework (Java DSL)

**Folder Structure:**
```
src/test/java/
  ├── features/users.feature
  └── karate-config.js
```

**Feature File:**
```gherkin
Feature: Get user by ID
  Scenario: Retrieve user
    Given url 'https://api.example.com/users/1'
    When method GET
    Then status 200
    And match response.name == 'John'
```

**Run Command:**
```bash
mvn test
```

**Dockerfile:**
```dockerfile
FROM maven:3.8.1-jdk-11
COPY . .
RUN mvn clean test
```

---

### 🧪 Supertest + Mocha

**Folder Structure:**
```
test/
  └── api.test.js
```

**Sample Test:**
```js
const request = require('supertest')('https://api.example.com');
describe('GET /users/1', () => {
  it('should return a user', async () => {
    await request.get('/users/1')
      .expect(200)
      .expect(res => res.body.name === 'John');
  });
});
```

**Dockerfile:**
```dockerfile
FROM node:18
WORKDIR /app
COPY . .
RUN npm install
CMD ["npm", "test"]
```

**CI/CD GitHub Actions:**
```yaml
jobs:
  supertest:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v2
      - run: npm ci
      - run: npm test
```

