import React, { useState } from "react";
import datachart from "../datachart.json";
import { dataModifier, fulfillBeginData } from "../Helper/action";
import PieChart from "./PieChart";
import { sortDataBySales } from "../Helper/utils";
import "./PieChart.css";

function DataChart() {
  const sortData = sortDataBySales(datachart);
  const [data] = useState(sortData);
  const beginData = fulfillBeginData(data);
  const [modifyData, setModifyData] = useState(beginData);

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
