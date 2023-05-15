public class Kata
{
  public static string CreatePhoneNumber(int[] numbers)
  {
    // Convert the array to a string
    String numberString = string.Join("", numbers);
    // Format the string
    return long.Parse(numberString).ToString("(000) 000-0000");
    }
}
/// the same function in javascript
/// function createPhoneNumber(numbers){
///  numbers = numbers.join('');
///  return '(' + numbers.substring(0, 3) + ') '
///    + numbers.substring(3, 6)
///    + '-'
///    + numbers.substring(6);
///    }