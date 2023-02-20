import 'dart:io';

/// Create a function that validates the correctness of a string
void main() {
  // print(stringValidator('A5i8%'));
  print(fridaysIterator(dateOfFirstFriday: '2027-09-17'));
  // fileConverter();
}

fridaysIterator({required String dateOfFirstFriday}) {
  var date = DateTime.parse(dateOfFirstFriday);
  var fridays = [];
  while (date.year < 2030) {
    if (date.weekday == DateTime.friday) {
      fridays.add(date);
    }
    date = date.add(Duration(days: 1));
  }
  return fridays;
}

bool stringValidator(String text) {
// min 6 characters
// max 15 characters
  bool charac = text.length >= 6 && text.length <= 15;
// contains at least one number
  bool number = text.contains(new RegExp(r'[0-9]')) &&
// the number of integers is at least 2
      text.split('').where((c) => int.tryParse(c) != null).length >= 2;
// the numbers should not be adjacent
  bool adjacent = !text.contains(new RegExp(r'[0-9]{2}'));
// contains at least one uppercase letter
  bool upper = text.contains(new RegExp(r'[A-Z]'));
// contains at least one lowercase letter
  bool lower = text.contains(new RegExp(r'[a-z]'));
// contains only one special character from this list: $ % >
  bool special = text.contains(new RegExp(r'[$%>]')) &&
//the number of special characters is only one
      text.split('').where((c) => ['\$', '%', '>'].contains(c)).length == 1;
// Each character should be unique
  bool unique = text.split('').toSet().length == text.length;
  return charac && number && adjacent && upper && lower && special && unique;
}

final inputPath =
    '/Users/sababuvercetti/Projects/AlgoExpert/Interviews/input.txt';
final excludePath =
    '/Users/sababuvercetti/Projects/AlgoExpert/Interviews/exclude.txt';
final outputPath =
    '/Users/sababuvercetti/Projects/AlgoExpert/Interviews/output.txt';

// do not change the name of this function
void fileConverter() {
  // read the input file
  var input = File(inputPath).readAsStringSync();
  // read the exclude file
  var exclude = File(excludePath).readAsStringSync();
  // save the lines that are in the input file but not in the exclude file to the output file
  // spaces at the beginning and end of the lines should be ignored
  var output = input
      .split('\r ')
      .where((line) => !exclude.contains(line.trim()))
      .join('\r ');
  File(outputPath).writeAsStringSync(output);
}
