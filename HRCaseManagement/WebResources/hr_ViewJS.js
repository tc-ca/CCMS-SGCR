function highlightPriority(rowData, userLCID) {
  if (rowData == null || rowData == "undefined") return;
  // read rowdata
  
  var str = JSON.parse(rowData);
  var priority = str.hr_priority;
  switch (priority) {
    case "High":
    case "Élevée":
      imgName = "hr_high-priority.svg";     
      break;    
    default:
      imgName = "";
      break;
  }
  var resultarray = [imgName];
  return resultarray;
}
