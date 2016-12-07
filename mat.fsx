#load "packages/MathNet.Numerics.FSharp/MathNet.Numerics.fsx"
#load "utils.fsx"

open MathNet.Numerics.LinearAlgebra


type Mat = {
  w : Matrix<float>
  dw : Matrix<float>
  n : int
  d : int
}

let zeros = Array.zeroCreate<float> 


let mat rows cols =
  {
    w = DenseMatrix.zero rows cols
    dw = DenseMatrix.zero rows cols
    n = rows
    d = cols
  }

let get m row col =
  m.w.[row,col]

let set m row col v =
  m.w.[row , col] <- v

let fillRand lo hi m = 
  { m with w = DenseMatrix.init m.n m.d  (fun _ _ -> Utils.randf lo hi) }

let randMat n d std =
  mat n d
  |> fillRand -std std


let mul m1 m2 =
  let out = mat m1.n m2.d
  { out with w = m1.w * m2.w }
  