console.log("test");
function validate(obj) {
  let methods = ["GET", "POST", "DELETE", "CONNECT"];
  let HTTPVersion = ["HTTP/0.9", "HTTP/1.0", "HTTP/1.1", "HTTP/2.0"];
  let uriRegex = /[\w.0-9\*]+/m;
  let messageRegex = /^[\<\>\\\&\'\"\)]+&/;
  if (!obj.method || !methods.includes(obj.method)) {
    throw new Error("Invalid request header: Invalid Method");
  }
  if (!obj.uri || obj.uri.length === "" || !uriRegex.test(obj.uri)) {
    throw new Error("Invalid request header: Invalid URI");
  }

  if (!obj.version || !HTTPVersion.includes(obj.version)) {
    throw new Error("Invalid request header: Invalid Version");
  }
  if (obj.message === undefined || messageRegex.test(obj.message)) {
    throw new Error("Invalid request header: Invalid Message");
  }

  return obj;
}

console.log(
  validate({
    method: "GET",
    uri: "svn.public.catalog",
    version: "HTTP/1.1",
    message: "",
  })
);
module.exports = validate;
