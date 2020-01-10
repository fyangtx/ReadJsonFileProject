** ReadMe **
1. This is a console project using C# and DotNet Core developed in VS2019
2. The purpose of this project is to show case how to read a JSON data file and parse it to a specific data object and use the data object to do some operation.
3. I used a simple XUnit test to read the same json file and test the expected result from Label Sum.
4. Data structure:
	JsonData class uses MenuList object which is created by JsonConvert.DeserializeObject<MenuList[]>.
	MenuList have properties: a header and a list of itemEntry.
	itemEntry have properties: Id, Label

