type Mat = {
  w : float []
  dw : float []
  n : int
  d : int
}

let zeros = Array.zeroCreate<float> 


let mat rows cols =
  {
    w = zeros (rows * cols)
    dw = zeros (rows * cols)
    n = rows
    d = cols
  }

let get m row col =
  m.w.[m.d * row + col]

let set m row col v =
  m.w.[m.d * row + col] <- v

