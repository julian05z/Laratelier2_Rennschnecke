// See https://aka.ms/new-console-template for more information


using Laratelier2_Rennschnecke;

Rennen testRennen = new Rennen("Race", 10000);

testRennen.addRennschnecke(new Rennschnecke("Jan", "schnecke", 10));
testRennen.addRennschnecke(new Rennschnecke("Leandro", "schnecke", 59));
testRennen.addRennschnecke(new Rennschnecke("David", "schnecke", 53));


Console.WriteLine(testRennen);

testRennen.durchfueren();
testRennen.toString();

testRennen.getPrintString();