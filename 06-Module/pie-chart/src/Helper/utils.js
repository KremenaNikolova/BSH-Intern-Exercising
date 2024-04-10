export function sortDataBySales(data) {
  return (data = data.sort((p1, p2) =>
    p1.value < p2.value ? 1 : p1.value > p2.value ? -1 : 0
  ));
}

export function dataWithPercentage(data) {
  const totalSumOfObjectsValue = data.reduce((acc, curr) => acc + curr.y, 0);

  const dataWithPercentage = data.map((obj) => ({
    ...obj,
    y: ((obj.y / totalSumOfObjectsValue) * 100).toFixed(2),
  }));

  return dataWithPercentage;
}
