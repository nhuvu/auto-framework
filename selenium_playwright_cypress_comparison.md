## UI Testing Frameworks Comparison: Selenium vs Playwright vs Cypress

This document compares three popular UI testing frameworks: **Selenium**, **Playwright**, and **Cypress**. It includes definitions, use cases, pros and cons, framework structure, supported languages, code examples, integrations with BDD frameworks and test reporting tools, how each handles element locators, standout advanced features, Docker setup, CI/CD integration, and test parallelization.

---

## 📌 Comparison Table

| Feature                    | Selenium                                 | Playwright                                 | Cypress                                 |
|----------------------------|------------------------------------------|--------------------------------------------|-----------------------------------------|
| **Definition**             | Open-source tool for automating browsers | Modern end-to-end testing framework by MS   | JavaScript-based end-to-end testing tool |
| **Usage**                  | Cross-browser automation, regression test| End-to-end, cross-browser testing           | Frontend testing focused on JS apps     |
| **Pros**                   | Mature, supports many languages/browsers | Fast, auto-waits, supports multiple browsers| Fast, great UI, easy to set up          |
| **Cons**                   | Slower, more boilerplate                 | Newer, smaller community                    | Chrome-only (experimental Firefox)      |
| **Framework**              | Selenium WebDriver, TestNG/JUnit         | Playwright Test                             | Cypress built-in framework              |
| **Programming Languages**  | Java, Python, C#, Ruby, JS               | JS, TS, Python, C#, Java                    | JavaScript, TypeScript                  |
| **Library Used**           | WebDriver, Selenium Grid, JUnit/TestNG   | Built-in Playwright API                     | Cypress API                             |
| **Run Method**             | Test runner (JUnit/TestNG), Maven/Gradle | `npx playwright test`                       | `npx cypress open/run`                  |
| **BDD Support**            | Cucumber (Gherkin + StepDefs)            | Cucumber-js                                 | Cucumber-preprocessor                   |
| **Report Tools**           | Allure, ExtentReports                    | Allure, HTML Reporter                       | Mochawesome, Allure                     |
| **Element Locators**       | By.id, By.name, By.xpath, By.cssSelector | `page.locator('selector')`, role locators   | `cy.get('selector')`, includes aliasing |
| **Advanced Features**      | Selenium Grid for distributed testing, BrowserMob proxy support | Auto-wait, context isolation, built-in video/screenshot, trace viewer | Time-travel UI, automatic retry, network stubbing |
| **Docker Support**         | ✅ Selenium Grid Docker                  | ✅ Built-in Docker support via playwright-docker | ✅ Cypress Docker base images available |
| **CI/CD Integration**      | Jenkins, GitHub Actions, GitLab, Azure DevOps | GitHub Actions, GitLab CI, Azure Pipelines | GitHub Actions, GitLab, CircleCI        |
| **Test Parallelization**   | Selenium Grid or TestNG parallel config | Built-in sharding and worker threads        | Parallelization via Cypress Cloud        |

---

## 📂 Folder Structure and Code Samples

### ✅ Selenium (Java + TestNG + Cucumber + Allure)

**Folder Structure:**
```
src/test/java/
  ├── runner/TestRunner.java
  ├── steps/LoginSteps.java
  ├── features/login.feature
  ├── pages/LoginPage.java
  ├── utils/DriverFactory.java
  └── reports/
```

**Dockerfile Example:**
```dockerfile
FROM maven:3.8.1-jdk-11
WORKDIR /tests
COPY . .
RUN mvn clean install
CMD ["mvn", "test"]
```

**CI/CD (GitHub Actions):**
```yaml
jobs:
  test:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v2
      - name: Run tests
        run: mvn clean test
```

### ⚡ Playwright (TypeScript + Cucumber-js + Allure)

**Folder Structure:**
```
features/
  ├── login.feature
  ├── steps/login.steps.ts
  └── support/hooks.ts
playwright.config.ts
```

**Dockerfile Example:**
```dockerfile
FROM mcr.microsoft.com/playwright:v1.38.0-focal
WORKDIR /app
COPY . .
RUN npm install
CMD ["npx", "playwright", "test"]
```

**CI/CD (GitHub Actions):**
```yaml
jobs:
  e2e:
    runs-on: ubuntu-latest
    container: mcr.microsoft.com/playwright:v1.38.0-focal
    steps:
      - uses: actions/checkout@v2
      - run: npm ci
      - run: npx playwright test
```

### 🧪 Cypress (JavaScript + Cucumber-preprocessor + Mochawesome)

**Folder Structure:**
```
cypress/
  ├── e2e/login.feature
  ├── e2e/step_definitions/login.js
  ├── support/pageObjects/LoginPage.js
  └── support/commands.js
cypress.config.js
```

**Dockerfile Example:**
```dockerfile
FROM cypress/included:13.7.1
WORKDIR /e2e
COPY . .
CMD ["npx", "cypress", "run"]
```

**CI/CD (GitHub Actions):**
```yaml
jobs:
  cypress-run:
    runs-on: ubuntu-latest
    steps:
      - uses: actions/checkout@v2
      - run: npm ci
      - run: npx cypress run
```

---