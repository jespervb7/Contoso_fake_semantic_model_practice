// Create a calculated table with a single column which is hidden:
var table = Model.AddCalculatedTable("Model Measures", "{0}");
table.Columns[0].IsHidden = true;
