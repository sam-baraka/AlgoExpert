void main(List<String> args) {
  List<int> x = [1, 2, 9, 1, 2, 3, 1, 4, 1, 5, 7];
  var y=x.toSet().toList();
  y.sort();
  print(y);
}
