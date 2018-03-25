Yes, `(a== 1 && a ==2 && a==3)` can evaluate to true.

Much discussion:

https://stackoverflow.com/questions/48270127/can-a-1-a-2-a-3-ever-evaluate-to-true


Some of the highest voted answers:

### JAVASCRIPT

Leveraging JS's loose equality operator:

```JAVASCRIPT
const a = {
  i: 1,
  toString: function () {
    return a.i++;
  }
}

if (a== 1 && a ==2 && a==3) {
  console.log('Hello World!');
}
```

An underhanded method - using whitespace characters that are recognised as valid in variable names:

N.B. The odd spacing in the original expression is apparently how the question was presented, so this could've been the approach the interviewer was looking for. More discussion and variations on this on the SO link.

```JAVASCRIPT
// For example, I've written this with Korean half-width Hangul characters in the variable names,
// in the places where these underscores are (slightly different to one posted on SO):
// var a = 1;
// var a_ = 2;
// var _a = 3;
var a = 1;
var aﾠ = 2;
var ﾠa = 3;
if (a== 1 && aﾠ ==2 && ﾠa==3) {
    console.log("Why hello there!")
}
```


### RUBY

A solution not listed on SO that works in Ruby, using a global variable:

```RUBY
$count = 0

def a
  $count += 1
end

if (a== 1 && a ==2 && a==3)
   puts "Whoa"
end
```

ﾠﾠﾠﾠﾠﾠﾠﾠﾠﾠﾠﾠ
