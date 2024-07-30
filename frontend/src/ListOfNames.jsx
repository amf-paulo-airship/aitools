//TODO: EXERCISE #6 - Using CoPilot Help refactor this JSX using Bullets list and CSS style making it more presentable and user-friendly

import React from "react";
import useNames  from "./hooks/useNames";

const ListOfNames = () => {

const LIST = useNames();

  return (
    <>
      {LIST.map((name, index) => (
        <p key={index}>{name}</p>
        ))}
    </>
  );
}

export default ListOfNames;
