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
    if (modifyData.length === 1) {
      return;
    }
    return popFromData(dataObj, setModifyData);
  }
  return pushToData(dataObj, setModifyData);
}
