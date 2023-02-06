// Задание 1
// Создайте функцию которая возводит переданное число в куб,
// необходимо вывести в консоль результат 2^3 степени + 3 ^ 3 степени

const cubeNumber = (number) => {
    return number * number * number;
}

console.log(cubeNumber(2) + cubeNumber(3));

// Задание 2
// Пользователь вводит с клавиатуры число, если ввёл текст,
// необходимо вывести что значение задано неверно.
// Создать фукнцию, которая высчитывает 13% от данного числа и выводит
// в консоль текст "Размер заработной платы за вычетом налогов равен значение"

const salary = (money) => {
    return money * 0.87;        
}

const userMoney = Number (prompt("Введите размер заработной платы"));

if (isNaN(userMoney)) {
    console.log("Вы ввели некорректное значение");
} else {
    console.log(`При зарплате ${userMoney} размер заработной платы за вычетом налогов равен ${salary(userMoney)}`);
}


// Задание 3
// Пользователь с клавиатуры вводит 3 числа, необходимо
// создать функцию, которая определяет максимальное значение среди этих чисел

const userNumOne = Number (prompt("Введите первое число из трех для поиска максимального"));
const userNumTwo = Number (prompt("Введите второе число из трех для поиска максимального"));
const userNumThree = Number (prompt("Введите третье число из трех для поиска максимального"));

const maxNumber = (NumberOne,NumberTwo,NumberThree) => {
    let maxNumber = 0;    
    NumberOne > NumberTwo ? maxNumber = NumberOne : maxNumber = NumberTwo;
    if (NumberThree > maxNumber) maxNumber = NumberThree;
    return maxNumber;
}

console.log(`Максимальное из чисел ${userNumOne}, ${userNumTwo}, ${userNumThree} будет число ${maxNumber(userNumOne,userNumTwo,userNumThree)}`);

// Необходимо реализовать четыре функции, каждая функция должна принимать по два
// числа и выполнять одну из операций (каждая функция выполняет одну из них):
// 1. Сложение
// 2. Разность
// 3. Умножение
// 4. Деление
// Необходимо сделать так, чтобы функция вернула число, например выражение
// console.log(sum(2, 6)); должно вывести число 8 в консоль (sum - функция
// сложения в данном примере, ваши названия функций могут отличаться).
// Округлять значения, которые возвращают функции не нужно, однако, обратите
// внимание на разность, функция должна вычесть из большего числа меньшее, либо
// вернуть 0, если числа равны.
// Функциям всегда передаются корректные числа, проверки на NaN, Infinity делать
// не нужно.

const userNumberOne = Number (prompt("Введите первое число"));
const userNumberTwo = Number (prompt("Введите второе число"));

const sum = (NumberOne,NumberTwo) => {
    const sum = NumberOne + NumberTwo;
    return sum;
}

console.log(`Результат сложения: ${sum(userNumberOne,userNumberTwo)}`);

const subtraction = (NumberOne,NumberTwo) => {
    let subtraction = 0;    
    if (NumberOne >= NumberTwo) subtraction = NumberOne - NumberTwo;
    else subtraction = NumberTwo - NumberOne;
    return subtraction;
}

console.log(`Результат вычитания меньшего из большего: ${subtraction(userNumberOne,userNumberTwo)}`)

const multiplication = (NumberOne,NumberTwo) => {
    const multiplication = NumberOne * NumberTwo;
    return multiplication;
}

console.log(`Результат умножения: ${multiplication(userNumberOne,userNumberTwo)}`)

const division = (NumberOne,NumberTwo) => {
    const division = NumberOne / NumberTwo;
    return division;
}

console.log(`Результат деления ${userNumberOne} на ${userNumberTwo} : ${division(userNumberOne,userNumberTwo)}`)
console.log(`Результат деления ${userNumberTwo} на ${userNumberOne} : ${division(userNumberTwo,userNumberOne)}`)
