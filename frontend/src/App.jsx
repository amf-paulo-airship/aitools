import "./App.css";
import React from "react";
import CalculatorUI from "./CalculatorUI";
import ListOfNames from "./ListOfNames";

const App = () => {

  return (
    <>
      <h1>List of Names</h1>
      <ListOfNames />
      <br />
      <br />
      <h1>Calculator</h1>
      <CalculatorUI />
    </>
  );
}

export default App;