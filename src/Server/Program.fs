open Saturn
open Giraffe.Core
open System

let appRouter = router {
    get "/text" (text "Hello World from Saturn")
}

let app =
    application {
        url "http://0.0.0.0:8085"
        use_router appRouter
        memory_cache
        use_static (__SOURCE_DIRECTORY__ + "/../../public")
    }

run app
