const express = require('express')
const fetch = require('node-fetch');

const app = express()
const port = 8080

const timeServiceAddress = checkEnvVariable('TIME_SERVICE_ADDRESS');
const helloServiceVersion = checkEnvVariable('HELLO_SERVICE_VERSION');

app.get('/', (req, res) => {
  console.log('Hello service got a request!');
  console.log(JSON.stringify(process.env, null, 2));
  fetch(`http://${timeServiceAddress}:8080`)
    .then(timeServerResponse => timeServerResponse.text())
    .then(body => res.send(`Hello there! I am HelloService version ${helloServiceVersion}. The time service says that the time is: ${JSON.parse(body).time}`));
});

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})

// Function to check environment variable
function checkEnvVariable(variableName) {
  const value = process.env[variableName];
  if (!value) {
    throw new Error(`Environment variable ${variableName} is not set.`);
  }
  return value;
}
