window.onload = function () {

    canv = document.getElementById("myFlappy");
    ctx = canv.getContext("2d");
    
    ctx.fillStyle = "black";
    ctx.fillRect(0, 0, canv.width, canv.height);

    //var bird = new Bird(canv, ctx);
    //bird.show();

    ctx.fillStyle = "white";
    ctx.fillRect(canv.width / 4, (canv.height / 2) - 12, 24, 24);

}

//function Bird(canv, ctx) {
//    this.y = height / 2;
//    this.x = width / 3;

//    this.show = function () {
//        ctx.fillStyle = "white";
//        ctx.fillRect(canv.width / 3, canv.height / 2, 25, 25);
//    }
//}