# REST Assured BDD-Style Cheat Sheet

A quick reference for writing expressive and structured REST Assured tests using `given()`, `when()`, and `then()` in Java.

---

## ✅ Structure Reminder

```java
given()
    .headers(...)
    .body(...)
.when()
    .get("/endpoint")
.then()
    .statusCode(200)
    .body("json.path", equalTo("value"))
    .log().all();
```

---

## 🔧 `given()` — Setup the Request

| Use Case                | Example |
|-------------------------|---------|
| Base URI                | `RestAssured.baseURI = "https://api.example.com";` |
| Set Header              | `.header("Authorization", "Bearer token")` |
| Multiple Headers        | `.headers("Content-Type", "application/json", "Accept", "application/json")` |
| Query Params            | `.queryParam("status", "active")` |
| Path Params             | `.pathParam("userId", 123)` |
| Request Body (JSON)     | `.body("{ \"name\": \"Nhu\" }")` |
| Request Body (POJO)     | `.body(myUserObject)` |
| Content Type            | `.contentType(ContentType.JSON)` |
| Relax SSL               | `.relaxedHTTPSValidation()` |

---

## 🚀 `when()` — Perform the Action

| Method | Example |
|--------|---------|
| GET    | `.when().get("/users")` |
| POST   | `.when().post("/users")` |
| PUT    | `.when().put("/users/{id}")` |
| DELETE | `.when().delete("/users/{id}")` |

---

## ✅ `then()` — Assert the Response

### Status Code

```java
.then().statusCode(200)
```

### Response Body (Hamcrest Matchers)

| Matcher            | Example |
|--------------------|---------|
| Equal To           | `.body("name", equalTo("Nhu"))` |
| Contains String    | `.body("email", containsString("@example.com"))` |
| Not Null           | `.body("id", notNullValue())` |
| List Size          | `.body("users", hasSize(5))` |
| Contains Items     | `.body("roles", hasItems("admin", "user"))` |
| Nested JSON        | `.body("user.address.city", equalTo("Hanoi"))` |

### Headers

```java
.then().header("Content-Type", "application/json")
```

### Log Response

```java
.then().log().all()
```

### Response Time

```java
.then().time(lessThan(2000L))
```

---

## 📤 Extracting Values

```java
Response response = 
    given().get("/users/1")
    .then().extract().response();

String name = response.path("name");
int id = response.path("id");
```

---

## 🧪 Common Matchers

| Matcher             | Description |
|---------------------|-------------|
| `equalTo(value)`    | Exact match |
| `containsString(s)` | Substring match |
| `hasItem(item)`     | List contains item |
| `notNullValue()`    | Field is not null |
| `hasSize(n)`        | List has specific size |
| `greaterThan(n)`    | Value is greater than n |

> Add `import static org.hamcrest.Matchers.*;` to your test class.

---

## 🎁 Bonus: Multiple Assertions

```java
.then()
    .statusCode(200)
    .body("name", equalTo("Nhu"))
    .body("email", containsString("@example.com"))
```

---

## 🛠 Extras

- Authentication  
```java
.auth().preemptive().basic("username", "password")
```

- Global Config  
```java
RestAssured.baseURI = "...";
RestAssured.useRelaxedHTTPSValidation();
```

---

Made for Java + REST Assured + TestNG ✨
