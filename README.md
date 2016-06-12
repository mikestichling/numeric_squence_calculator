# Numeric-sequence-calculator-frontend

![](https://api.travis-ci.org/mikestichling/numeric_squence_calculator.svg)

This application is a way to calculate the numeric sequences from 0 to a number specified by the user. 

## Prerequisites

You will need the following things properly installed on your environment.

* Visual Studio .Net Framework 4.5.1
* [Git](http://git-scm.com/)
* [NUnit 3 Test Adapter](Https://visualstudiogallery.msdn.microsoft.com/0da0f6bd-9bb6-4ae3-87a8-537788622f2d)

## Installation

* `git clone https://github.com/mikestichling/numeric_squence_calculator.git`
* change into the new directory
* open NumericSequenceCalculator.sln
* Build the application
* Run the tests using NUnit 3 Test Adapter
* Run the application using Visual Studio

### Running

You can point your browser to `http://localhost:56033/index.html` once the application is built and running. 

If you want to test the API independently from the Frontend, you can point your browser to `http://localhost:56033/swagger/ui/index` and start interacting with the methods on the API. [Swagger](http://swagger.io/) is a framework for testing and navigating an API.

### Deploying

Deploy the app is as simple as pushing the latest changes to GitHub. Azure will trigger a deployment at the latest push.
