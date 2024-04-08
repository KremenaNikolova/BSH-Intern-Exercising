export function pushToData(dataObj, setModifyData) {
  setModifyData((modifyData) => [...modifyData, dataObj]);
}

export function popFromData(dataObj, setModifyData) {
  setModifyData((modifyData) => {
    return modifyData.filter((data) => data.name !== dataObj.name);
  });
}

export function dataModifier(dataObj, setModifyData, modifyData) {
  const isAdded = modifyData.find((data) => data.name === dataObj.name);
  if (isAdded) {
    if (modifyData.length === 1) {
      return;
    }
    return popFromData(dataObj, setModifyData);
  }
  return pushToData(dataObj, setModifyData);
}
