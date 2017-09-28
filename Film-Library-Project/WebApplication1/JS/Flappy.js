var bird;

function setup() {
    canv =  //document.getElementBy("myFlappy");
    ctx = canv.getContext("2d");
    ctx.fillStyle = "black";
    ctx.fillRect(0, 0, canv.width, canv.height);

    //bird = new Bird();
    alert("yo");
    //var bird = new Bird();
    alert("yo2");
}

function draw()
{
    //Create();
    bird.update();
    bird.show();
    alert("yo3");
}

function Bird() {
    this.x = width / 4;
    this.y = (height / 2) - 12;
    this.gravity = 0.1;
    this.velocity = 15;

    this.show = function () {
        fillStyle = "white";
        fillRect(this.x, this.y, 24, 24);
    }

    this.update = function () {
        this.y += this.velocity;
        this.velocity += this.gravity;
    }
}