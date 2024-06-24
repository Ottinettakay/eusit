// Create an instance of JsonPlayerPrefs with the file path
JsonPlayerPrefs jsonPlayerPrefs = new JsonPlayerPrefs("path/to/file.json");

// Set a string value
jsonPlayerPrefs.SetString("key", "value");

// Get a string value
string retrievedValue = jsonPlayerPrefs.GetString("key");
