const signForm = document
  .querySelector(".sign__form")
  .addEventListener("input", () => {
    const userPasswordFirst = document.querySelector(".password1");
    const userPasswordSecond = document.querySelector(".password2");
    if (userPasswordFirst.value === "") {
      userPasswordFirst.style = "border: 2px solid red";
      userPasswordSecond.style = "border: 2px solid red";
    } else if (userPasswordFirst.value !== userPasswordSecond.value) {
      userPasswordFirst.style = "border: 2px solid red";
      userPasswordSecond.style = "border: 2px solid red";
    } else if (userPasswordFirst.value === userPasswordSecond.value) {
      userPasswordFirst.style = "border: 2px solid green";
      userPasswordSecond.style = "border: 2px solid green";
    }
  });