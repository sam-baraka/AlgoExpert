void main() {
  drawPyramid(5);
}

void drawPyramid(int height) {
  for (var i = 0; i < height; i++) {
    var line = '';
    for (var j = 0; j < height - i - 1; j++) {
      line += ' ';
    }
    for (var k = 0; k < i * 2 + 1; k++) {
      line += '*';
    }
    print(line);
  }
}
