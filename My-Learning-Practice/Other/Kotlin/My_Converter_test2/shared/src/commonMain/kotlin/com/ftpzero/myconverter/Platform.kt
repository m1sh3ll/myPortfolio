package com.ftpzero.myconverter

interface Platform {
    val name: String
}

expect fun getPlatform(): Platform