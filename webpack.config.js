// Note this only includes basic configuration for development mode.
// For a more comprehensive configuration check:
// https://github.com/fable-compiler/webpack-config-template

var path = require("path");

module.exports = {
    mode: "development",
    entry: {
        app1: "./src/App1/App1.fs.js",
        app2: "./src/App2/App2.fs.js"
    },
    output: {
        path: path.join(__dirname, "./public"),
        filename: "[name]/bundle.js",
    },
    devServer: {
        publicPath: "/",
        contentBase: "./public",
        port: 8080,
    },
    module: {
    }
}
