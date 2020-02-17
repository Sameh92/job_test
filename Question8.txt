class MathClass{
  @subtract(1)
  @multiply(2)
  addOne(n:number){
    return n+1;
  }
}

function multiply(m:number){
  return function (target:any,propertyKey: string, descriptor: PropertyDescriptor){
    var old = descriptor.value;
    descriptor.value = function(n:number){
      return old(n) * m;
    }
  }
}

function subtract(m:number){
  return function (target:any,propertyKey: string, descriptor: PropertyDescriptor){
    var old = descriptor.value;
    descriptor.value = function(n:number){
      return old(n) - m;
    }
  }
}

console.log(new MathClass().addOne(2))