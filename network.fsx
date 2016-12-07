#load "mat.fsx"
open Mat

type LSTMLayer = {
  Wix : Mat
  Wih : Mat
  bi : Mat
  Wfx : Mat
  Wfh : Mat
  bf : Mat
  Wox : Mat
  Woh : Mat
  bo : Mat

  Wcx : Mat
  Wch : Mat
  bc : Mat
}


type RNNLayer = {
  Wxh : Mat
  Whh : Mat
  bhh : Mat
  
}

type LSTMModel = {
  Wil : Mat
  hiddenLayers : LSTMLayer list
  Whd : Mat
  bd : Mat
}

type RNNModel = {
  Wil : Mat
  hiddenLayers : RNNLayer list
  Whd : Mat
  bd : Mat
}

type Model =
  | LSTM of LSTMModel
  | RNN of RNNModel