export function show(): void {
    document.getElementById("splash")?.classList.remove("hidden");
    console.log("show splasg");
}

export function hide(): void {
    document.getElementById("splash")?.classList.add("hidden");
    console.log("hide splasg");
}
