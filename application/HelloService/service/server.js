const express = require('express')
const fetch = require('node-fetch');

const app = express()
const port = 8080

app.get('/', (req, res) => {
  fetch('http://52.148.144.7:8080')
    .then(timeServerResponse => timeServerResponse.text())
    .then(body => res.send(`Hello there! The time is: ${JSON.parse(body).time}`));
});

app.listen(port, () => {
  console.log(`Example app listening on port ${port}`)
})
