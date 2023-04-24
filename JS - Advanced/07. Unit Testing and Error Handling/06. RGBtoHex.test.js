const expect = require("chai").expect;
const rgbToHexColor = require("./06. RGBtoHex");

describe("rgbToHexColor - Regular cases", () => {
  it('should return "#010203" on rgbToHexColor(1,2,3)', () => {
    expect(rgbToHexColor(1, 2, 3)).to.equal("#010203");
  });

  it('should return undefined on rgbToHexColor("a",2,3)', () => {
    expect(rgbToHexColor("a", 2, 3)).to.be.undefined;
  });

  it('should return undefined on rgbToHexColor(1,"a",3)', () => {
    expect(rgbToHexColor(1, "a", 3)).to.be.undefined;
  });

  it('should return undefined on rgbToHexColor(1,2,"a")', () => {
    expect(rgbToHexColor(1, 2, "a")).to.be.undefined;
  });

  it("should return undefined on rgbToHexColor(-1,2,3)", () => {
    expect(rgbToHexColor(-1, 2, 3)).to.be.undefined;
  });

  it("should return undefined on rgbToHexColor(1,-2,3)", () => {
    expect(rgbToHexColor(1, -2, 3)).to.be.undefined;
  });

  it("should return undefined on rgbToHexColor(1,2,-3)", () => {
    expect(rgbToHexColor(1, 2, -3)).to.be.undefined;
  });

  it("should return undefined on rgbToHexColor(256,2,3)", () => {
    expect(rgbToHexColor(256, 2, 3)).to.be.undefined;
  });

  it("should return undefined on rgbToHexColor(1,256,3)", () => {
    expect(rgbToHexColor(1, 256, 3)).to.be.undefined;
  });

  it("should return undefined on rgbToHexColor(1,2,256)", () => {
    expect(rgbToHexColor(1, 2, 256)).to.be.undefined;
  });

  it("should return undefined on rgbToHexColor(2,3)", () => {
    expect(rgbToHexColor(2, 3)).to.be.undefined;
  });

  it("should return undefined on rgbToHexColor()", () => {
    expect(rgbToHexColor()).to.be.undefined;
  });

  it('should return "#010203" on rgbToHexColor(0,255,100)', () => {
    expect(rgbToHexColor(0, 255, 100)).to.equal("#00FF64");
  });
});
