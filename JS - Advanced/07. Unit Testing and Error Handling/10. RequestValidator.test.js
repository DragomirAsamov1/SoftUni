const expect = require("chai").expect;
const validate = require("./10. RequestValidator");

describe("validate - regular cases", () => {
  let expected;

  beforeEach(function () {
    expected = {
      method: "GET",
      uri: "svn.public.catalog",
      version: "HTTP/1.1",
      message: "",
    };
  });

  it("Right input parameters should return proper object", function () {
    let result = {
      method: "GET",
      uri: "svn.public.catalog",
      version: "HTTP/1.1",
      message: "",
    };

    expect(validate(expected)).to.deep.equal(result);
  });

  it("Should return error message when we pass empty method", function () {
    expected.method = "";

    expect(validate(expected))
      .to.throw(Error)
      .which.has.property("message", "Invalid request header: Invalid Method");
  });

  it("Should return error message when we pass not included method", function () {
    expected.method = "OPTIONS";

    expect(validate(expected))
      .to.throw(Error)
      .which.has.property("message", "Invalid request header: Invalid Method");
  });

  it("Should return error message when we pass incorrect uri", function () {
    expected.uri = "<";

    expect(validate(expected))
      .to.throw(Error)
      .which.has.property("message", "Invalid request header: Invalid URI");
  });

  it("Should return error message when we pass empty uri", function () {
    expected.uri = "";

    expect(validate(expected))
      .to.throw(Error)
      .which.has.property("message", "Invalid request header: Invalid URI");
  });

  it("Should return error message when we pass incorrect version", function () {
    expected.version = "version";

    expect(validate(expected))
      .to.throw(Error)
      .which.has.property("message", "Invalid request header: Invalid Version");
  });

  it("Should return error message when we pass empty verion", function () {
    expected.version = "";

    expect(validate(expected))
      .to.throw(Error)
      .which.has.property("message", "Invalid request header: Invalid Version");
  });

  it("Should return error message when we pass special character in message", function () {
    expected.message = ">";

    expect(validate(expected))
      .to.throw(Error)
      .which.has.property("message", "Invalid request header: Invalid Version");
  });

  it("Should return Invalid Method message when we pass incorrect properties", function () {
    expected = {
      method: "options",
      uri: "",
      version: "version",
      message: "<",
    };

    expect(validate(expected))
      .to.throw(Error)
      .which.has.property("message", "Invalid request header: Invalid Method");
  });
});
