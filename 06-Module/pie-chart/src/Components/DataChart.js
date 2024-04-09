import React, { useState } from "react";
import datachart from "../datachart.json";
import { dataModifier } from "../Helper/action";
import PieChart from "./PieChart";

import "./PieChart.css";

function DataChart() {
  const [data] = useState(datachart);
  const firstObj = {
    label: data[0].name,
    y: data[0].value,
  };
  const [modifyData, setModifyData] = useState([firstObj]);

  return (
    <div className="main-container">
      <PieChart data={modifyData} />
      <div className="chart-list-container">
        {data.map((dataObj, index) => {
          return (
            <li key={index}>
              <button
                className="btn-name btn-push"
                onClick={() =>
                  dataModifier(dataObj, setModifyData, modifyData, index)
                }
              >
                {dataObj.name}
              </button>
            </li>
          );
        })}
      </div>
    </div>
  );
}

export default DataChart;
