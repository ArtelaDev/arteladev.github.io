export function show(): void {
    document.getElementById("splash")?.classList.remove("hidden");
}

export function hide(): void {
    document.getElementById("splash")?.classList.add("hidden");
}
