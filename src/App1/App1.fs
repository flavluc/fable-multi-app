module App1

open Fable.Import
open Browser.Dom

let Title = "App 1!"

let content = document.getElementById "content"
content.innerHTML <- (sprintf "<h1>%s</h1>" Title)
