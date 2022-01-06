module App2

open Fable.Import
open Browser.Dom

let Title = "App 2!"

let content = document.getElementById "content"
content.innerHTML <- (sprintf "<h1>%s</h1>" Title)
