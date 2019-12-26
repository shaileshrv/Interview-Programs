const express = require('express'); //use express js to handle the request and response -- npm install express
var cors = require('cors'); // import cors in the project   -- npm install cors
const bodyParser = require('body-parser'); // parse body data   - npm install body-parser

const app = express();
app.use(cors()); // enable cores

// enable body-parse
app.use(
    bodyParser.urlencoded({
        extended: true
    })
)

app.use(bodyParser.json())

const productList = [
    { code: 'C1001', name: 'Coke', quantity: 2000, prize:20 },
    { code: 'C1002', name: 'Mazza', quantity: 9000,prize:10 },
    { code: 'C1003', name: 'Redbull', quantity: 500, prize: 100 },
    { code: 'C1004', name: 'Pepsi', quantity: 5000, prize: 20 },
]

// first request -- http://localhost:8080/
app.get('/', (req, res) => {
    res.send(productList);
});

// request for get product info by code -- http://localhost:8080/product?code=C1001
app.get('/product/:code', (req, res) => {
    // get body data 
    var code = req.params['code'];
    var product = {}
    for (var index = 0; index < productList.length; index++) {
        if (productList[index].code == code) {
            product = productList[index];
            break;
        }
    }
    res.json(product);
});

// get product list data -- http://localhost:8080/product/all
app.get('/productList', (req, res) => {
    console.log("gujui");
    res.json(productList);
});

// add new product -- http://localhost:8080/product/add {code:'C1009', name:'Test', quantity: 5000, prize: 20 }
app.post('/productAdd', (req, res) => {
    console.log(req.body);
    productList.push(req.body);
    res.end();
});

// create port on which our app runs, plz check if port is used by any other process 
const port = process.env.PORT || 8080;
app.listen(port, () => console.log(`Listening on port ${port}..`));