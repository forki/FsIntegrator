﻿namespace Camel

open Camel.FileHandling

module Producers =
    type From = struct end
    type From with
        /// Create a File-listener Producer, which listens to a folder on the local filesystem
        static member File : path : string -> File

        /// Create a File-listener Producer, which listens to a folder on the local filesystem
        static member File : path : string * options : FileOption list -> File


