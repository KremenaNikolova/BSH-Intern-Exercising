import React, { Component } from "react";
import CanvasJSReact from "@canvasjs/react-charts";
import { dataWithPercentage } from "../Helper/utils";

var CanvasJSChart = CanvasJSReact.CanvasJSChart;
class PieChart extends Component {
  render() {
    const { data } = this.props;
    const options = {
      exportEnabled: true,
      animationEnabled: true,
      title: {
        text: "Sales",
      },
      data: [
        {
          type: "pie",
          startAngle: 75,
          toolTipContent: "<b>{label}</b>: {y}%",
          legendText: "{label}",
          indexLabelFontSize: 16,
          indexLabel: "{label} - {y}%",
          dataPoints: dataWithPercentage(data),
        },
      ],
    };
    return (
      <div>
        <CanvasJSChart
          options={options}
          /* onRef={ref => this.chart = ref} */
        />
        {/*You can get reference to the chart instance as shown above using onRef. This allows you to access all chart properties and methods*/}
      </div>
    );
  }
}
export default PieChart;
