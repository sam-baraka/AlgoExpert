


fun StringChallenge(str: String):String{
    // return proper camel case string
    var result = ""
    var isUpper = false
    for (i in str.indices) {
        if (str[i] == ' ') {
            isUpper = true
        } else {
            if (isUpper) {
                result += str[i].toUpperCase()
                isUpper = false
            } else {
                result += str[i]
            }
        }
    }

    
   

}

fun main(args: Array<String>) {
    println(StringChallenge(readLine()!!))
}