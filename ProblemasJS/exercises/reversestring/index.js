// --- Directions
// Given a string, return a new string with the reversed
// order of characters
// --- Examples
//   reverse('apple') === 'leppa'
//   reverse('hello') === 'olleh'
//   reverse('Greetings!') === '!sgniteerG'

function reverse(str) {
    let reversed = "";
    for (let char in str){
        reversed = char + reversed;
    }
    return reversed;
}

module.exports = reverse;


// function reverse(str) {
//     return str.split('').reverse().join('');
// }