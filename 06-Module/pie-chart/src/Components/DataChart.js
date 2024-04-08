import React, { useState } from "react";
import datachart from "../datachart.json";
import { dataModifier } from "../Helper/action";
import PieArcLabel from "./PieChart";

function DataChart() {
  const [data] = useState(datachart);
  const [modifyData, setModifyData] = useState([data[0]]);

  return (
    <>
      {data.map((dataObj, index) => {
        return (
          <li key={index}>
            <button
              className="btn-name btn-push"
              onClick={() => dataModifier(dataObj, setModifyData, modifyData)}
            >
              {dataObj.name}
            </button>
          </li>
        );
      })}

      <PieArcLabel data={modifyData} />
    </>
  );
}

export default DataChart;
