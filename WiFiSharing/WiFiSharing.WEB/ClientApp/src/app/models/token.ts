export class Token {
    constructor(
        public id: number,
        public auth_token: string,
        public expires_in: number
    ) { }
}