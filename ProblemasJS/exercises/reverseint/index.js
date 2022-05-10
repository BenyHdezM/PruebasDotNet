// --- Directions
// Given an integer, return an integer that is the reverse
// ordering of numbers.
// --- Examples
//   reverseInt(15) === 51
//   reverseInt(981) === 189
//   reverseInt(500) === 5
//   reverseInt(-15) === -51
//   reverseInt(-90) === -9

function reverseInt(n) {
    var input = n.toString().toCharArray();
    Array.Reverse(input);
    let output = int.Parse(input);
    if(n<0) return output*-1;
    return output;
}

module.exports = reverseInt;
