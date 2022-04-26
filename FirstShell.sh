# This is a comment
# It is like putting a sticky note to your code to give a more meaningful message 
# of what you are doing in this script
# Echo is a way for us to give feedback to the person running the shell script
echo "This is your first shell script."


# Variables 
msg="Hello World Variable"
echo $msg # $ Syntax is what need to write to specify a variable

#Control Flow
# They are a way to tell the program to run muliple lines of code multiple times
# We can tell the program to run lines of code if a condition is met

# If Statements
ten=10
five=5
thirteen=13


echo "===First If==="
if [ "$ten" -ge "$five" ]
then
echo "Greater!"
echo "$ten > $five"
fi

echo "This is outside of the then fi"

echo "===Second If==="

if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -le "$ten" ]
then
echo "Lesser!"
echo "$five < $ten"
fi

echo "===Third If==="
if [ "$five" -ge "$ten" ]
then
echo "Greater!"
echo "$five > $ten"
elif [ "$five" -ge "$thirteen" ]
then
echo "Greater!"
echo "$five > $thirteen"
else
echo "Nothing Matches"
fi

# Loops Statement
# A way to repeat multiple linse of code x amount of times you want

# For Loops statement
# Will repeat x amount of times
# Useful if you know how many times you need to execute those lines of code

echo "===First Loop==="
for number in 10 5 World 1 2
do
echo "Hello $number"
done

echo "===Second Loop==="
for i in {1..10}
do
echo "$i"
done

echo "===While Loops==="
# While Loop statement
# Useful if you don't know how many times you need to execute those lines of code

while [ "$five" -le "$ten" ]
do
echo "Lesser!"
five=$(($five+1)) # $((mathematical operation)) syntax is how we can do math syntaxes
echo "$five"
done

# Input and Output
# We can ask for input from the user that is using the shell scripting and output some sort of response
echo "What is  your name?"
read name # Read [whatever variable name you specify] will store the user input in that vartiable

echo "Hello $name, Welcome to programming!"

# Making a shell menu
clear # clear command will clear all the text in the terminal

repeat="true"

while [ "$repeat" == "true" ]
do
echo "Welcome to shell scripting!"
echo "What do you want to do today?"
echo "Enter 1 for adding two numbers?"
echo "Enter 2 to exit"

read answer
if [ "$answer" == "1" ]
then
	echo "Give me number 1"
	read num1
	echo "Give me number 2"
	read num2
	echo "The sum is $(($num1+$num2))"
elif [ "$answer" == "2" ]
then
	repeat="false"
else
	echo "Please enter a correct option"
fi

done
