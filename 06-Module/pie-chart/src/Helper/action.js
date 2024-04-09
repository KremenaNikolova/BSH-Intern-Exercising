export function pushToData(dataObj, setModifyData) {
  const newObj = {
    label: dataObj.name,
    y: dataObj.value,
  };
  setModifyData((modifyData) => [...modifyData, newObj]);
}

export function popFromData(dataObj, setModifyData) {
  setModifyData((modifyData) => {
    return modifyData.filter((data) => data.label !== dataObj.name);
  });
}

export function dataModifier(dataObj, setModifyData, modifyData) {
  const isAdded = modifyData.find((data) => data.label === dataObj.name);
  if (isAdded) {
    if (modifyData.length === 1 || modifyData.length + 1 === 5) {
      return;
    }
    return popFromData(dataObj, setModifyData);
  }
  return pushToData(dataObj, setModifyData);
}

export function fulfillBeginData(data) {
  let counter = 0;
  let fulfillBeginData = [];
  while (counter < 3 || data.length - 1 === counter) {
    const obj = {
      label: data[counter].name,
      y: data[counter].value,
    };
    fulfillBeginData = [...fulfillBeginData, obj];
    counter++;
  }

  return fulfillBeginData;
}
