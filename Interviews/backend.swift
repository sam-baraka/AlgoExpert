import Foundation

func LogDumpGetUnique() -> String {

  let log_dump = "name=John Trust, username=john3, email=john3@gmail.com, id=434453; name=Hannah Smith, username=hsmith, email=hsm@test.com, id=23312; name=Hannah Smith, username=hsmith, id=3223423, email=hsm@test.com; name=Robert M, username=rm44, id=222342, email=rm@me.com; name=Robert M, username=rm4411, id=5535, email=rm@me.com; name=Susan Vee, username=sv55, id=443432, email=susanv123@me.com; name=Robert Nick, username=rnick33, id=23432, email=rnick@gmail.com; name=Robert Nick II, username=rnickTemp34, id=23432, email=rnick@gmail.com; name=Susan Vee, username=sv55, id=443432, email=susanv123@me.com;"

//Example Input
//name=Dan B, username=db, email=db@gmail.com, id-123; name-Hannah, username-hsmith, id=333, email=hsm@test.com; name=Dan Brick, username=db, email=db@gmail.com, id=663;
//Example Output
//name=Dan B, username=db, email=db@gmail.com; name-Hannah, username=hsmith, email=hsm@test.com;


}

print(LogDumpGetUnique())