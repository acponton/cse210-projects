const newParagraph = document.createElement("p");
newParagraph.innerText = "Added with Javascript!";
document.body.appendChild(newParagraph);

const newImage =document.createElement("img");
newImage.setAttribute("src", "https://placeimg.com/200/200/animals");
newImage.setAttribute("alt", "Animals");
document.body.appendChild(newImage);

const newDiv = document.createElement("div");
newDiv.innerHTML = "<ul><li>One</li><li>Two</li><li>Three</li></ul>";
document.body.appendChild(newDiv);

const newSection = document.createElement("section");
const newH2 = document.createElement("h2");
newH2.innerText = "CSE 121b";
newSection.appendChild(newH2);

const newp = document.createElement("p");
newp.innerText = "Welcome to Javascript Language";
newSection.appendChild(newp);

document.body.appendChild(newSection);

// ***Another way to add p and h2 at same time***
// const newSection = document.createElement("section");
// newSection.innerHTML = "<h2>CSE 121b</h2><p>Welcome to Javascript Language</p>";
// document.body.appendChild(newSection);