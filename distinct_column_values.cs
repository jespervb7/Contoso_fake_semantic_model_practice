// Construct the DAX expression to get all distinct column values, from the selected column:
var dax = string.Format("ALL({0})", Selected.Column.DaxObjectFullName);

// Evaluate the DAX expression against the connected model:
var result = EvaluateDax(dax);

// Output the DataTable containing the result of the DAX expression:
Output(result);
